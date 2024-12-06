'use strict';
const controller = {};
const models = require('../models');
controller.showHomepage = async (req, res) => {
    const threadsShow = await models.Thread.findAll({
        attributes: ['id', 'userId', 'content','mediaUrl', 'createdAt', 'updatedAt'],
        order: [['createdAt', 'ASC']],
        limit: 5,
    });
    res.render('home', {
        threadsShow,
    });
}
module.exports = controller;   