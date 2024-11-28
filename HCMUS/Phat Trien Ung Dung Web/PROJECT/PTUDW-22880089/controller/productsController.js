'use strict';
let controller = {};
const { where } = require('sequelize');
const models = require('../models');

controller.show = async (req, res) => {
    
    let category = isNaN(req.query.category) ? 0 : parseInt(req.query.category);


    let categories = await models.Category.findAll(
        {
            include: [{
                model: models.Product
               
            }]
        });
    res.locals.categories = categories;
    let options = {
        attributes: ['id', 'name', 'imagePath', 'stars', 'price', 'oldPrice'],
        where: {}
    };
    if(category > 0){
        options.where.categoryId = category;
    }

    let products = await models.Product.findAll(options);
    res.locals.products = products;
    res.render('product-list');
}

module.exports = controller;