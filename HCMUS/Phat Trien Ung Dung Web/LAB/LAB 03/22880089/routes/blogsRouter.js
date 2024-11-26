const express = require('express');
const router = express.Router();
const controller = require('../controllers/blogsController');

router.use(controller.init);    //middleware
//trang chu
router.get('/', controller.viewList);
//trang chi tiet
router.get('/:id', controller.viewDetails);

module.exports = router;