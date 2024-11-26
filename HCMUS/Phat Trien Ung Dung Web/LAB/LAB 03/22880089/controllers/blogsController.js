const controller = {};
const models = require('../models');
const sequelize = require('sequelize');
const Op = sequelize.Op;

controller.init = async (req, res, next) => {
    //lay danh sach categories dua ra view
    let categories = await models.Category.findAll({
        attributes: ['id', 'name'],
        include: [
            {
                model: models.Blog,
            },
        ],
    });
    res.locals.categories = categories;

    //lay danh sach tags dua ra view
    let tags = await models.Tag.findAll();
    res.locals.tags = tags;

    next(); //chuyen xu ly sang middleware hoac controller tiep theo 
}

controller.viewList = async (req, res) => {
    let categoryId = isNaN(req.query.category) ? 0 : parseInt(req.query.category);

    let tagId = isNaN(req.query.tag) ? 0 : parseInt(req.query.tag);

    let keyword = req.query.keyword ? req.query.keyword.trim() : '';

    let options = {
        //lay ra cac thuoc tinh can lay: id, title, imagePath, summary, createdAt
        attributes: ['id', 'title', 'imagePath', 'summary', 'createdAt'],
        //lay ra comment cua blog
        include: [
            {
                model: models.Comment,
            },
        ],
        where: {},
    };  //lay du lieu tu database can thoi gian => dung async await
    //Tiep den, dua danh sach cac blogs moi lay tu database ra view
    //Dua danh sach cac blogs ra tren view

    if (categoryId > 0) {
        options.where.categoryId = categoryId;  //lay ra cac blog cua mot category do nguoi dung chon
    }

    if (tagId > 0) {
        options.include.push({
            model: models.Tag,
            where: { id: tagId},
        });
    }

    if (keyword != '') {
        options.where.title = {
            [Op.like]: `%${keyword}%`,
        };
    }

    let blogs = await models.Blog.findAll(options);

    let limit = 2; 
    let page = isNaN(req.query.page) ? 1 : Math.max(1, parseInt(req.query.page));
    let offset = (page -1) * limit;
    let selectedBlogs = blogs.slice(offset, offset + limit);    //lay ra 2 blog moi trang
    let pagination = {
        page, 
        limit,
        totalRows: blogs.length,
        queryParams: req.query,
    }
    res.locals.pagination = pagination;
    res.locals.blogs = selectedBlogs;
    res.render('index');
}

controller.viewDetails = async (req, res) => {
    let id = isNaN(req.params.id) ? 0 : parseInt(req.params.id);
    //Dua ra chi tiet cua mot blog dua ra view
    let blog = await models.Blog.findOne({
        where: { id},
        include: [
            { model: models.User },
            { model: models.Category },
            { model: models.Tag },
        ]
    });
    //Dua ra view
    res.locals.blog = blog;
    res.render('details');
}
module.exports = controller;