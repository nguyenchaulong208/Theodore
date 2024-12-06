'use strict';
const express = require('express');
const router = express.Router();
const controller = require('../controllers/indexController');
router.get('/createTables', (req, res) => {
    let models = require('../models');
    models.sequelize.sync().then(() => {
        res.send('Table created!');
    });
}
);
module.exports = router;