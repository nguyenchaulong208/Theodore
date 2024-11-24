const controller = {};

controller.showIndex = (req, res) => {
  res.render("index");
};

controller.showProfile = (req, res) => {
  res.render("my-profile");
};

controller.showLogin = (req, res) => {
  res.render("auth-login", { layout: "auth" });
};

controller.showRegister = (req, res) => {
  res.render("auth-register", { layout: "auth" });
};

module.exports = controller;
