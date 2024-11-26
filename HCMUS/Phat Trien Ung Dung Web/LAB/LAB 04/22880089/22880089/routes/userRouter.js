const express = require("express");
const router = express.Router();
const controller = require("../controllers/userController");

router.get("/", controller.show);
router.post('/', controller.addUser);
router.delete('/:id', controller.deleteUser);
router.put('/', controller.editUser);
module.exports = router;
