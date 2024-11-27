'use strict';
const controller = {};
const models = require('../models');
controller.showHomepage = async (req, res) => {
    const featuredProducts = await models.Product.findAll({
        attributes: ['id', 'name', 'imagePath', 'stars','price','oldPrice'],
        order:[['stars','DESC']],
        limit: 10
        

    });
res.locals.featuredProducts = featuredProducts;



    const categories = await models.Category.findAll();
    const secondArrayy = categories.splice(2,2);
    const thirdArray = categories.splice(1,1);
    res.locals.categaryArray = [categories,secondArrayy,thirdArray];
    const Brand = models.Brand;
    const brands = await Brand.findAll();
    res.render('index',{brands:brands});
}
controller.showPage = (req, res, netx) => {
    const pages =['cart','checkout','product','login','wishlist','contact','product-detail','product-list','my-account'];
    if(pages.includes(req.params.page))
        return res.render(req.params.page);
    netx();
}

module.exports = controller;