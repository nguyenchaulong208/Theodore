const express = require("express");
const router = express.Router();
const controller = require("../controllers/authController");

router.get("/", controller.showIndex);
router.get("/profile", controller.showProfile);

router.get("/login", controller.showLogin);
router.get("/register", controller.showRegister);

module.exports = router;
