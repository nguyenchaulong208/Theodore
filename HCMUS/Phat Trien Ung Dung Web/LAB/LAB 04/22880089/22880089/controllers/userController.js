const controller = {};
const models = require("../models");

controller.show = async (req, res) => {
  res.locals.users = await models.User.findAll({
    attributes: [
      "id",
      "imagePath",
      "username",
      "firstName",
      "lastName",
      "mobile",
      "isAdmin",
    ],
    order: [["createdAt", "DESC"]],
  });
  res.render("user-management");
};

controller.addUser = async (req, res) => {
    let { firstName, lastName, username, mobile, isAdmin } = req.body;
    try {
        await models.User.create({
            firstName,
            lastName,
            username,
            mobile,
            isAdmin: isAdmin ? true : false,
        });
        res.redirect("/users");
    } catch (error) {
        console.log(error);
        res.send('Can not add user!');
    }     
}
controller.deleteUser = async (req, res) => {
    let id = isNaN(req.params.id) ? 0 : parseInt(req.params.id);
    try {
        await models.User.destroy({
            where: {
                id: id,
            },
        });
        res.redirect('/users');
    } catch (error) {
        console.log(error);
        res.send('Can not delete user!');
    }
    
}

controller.editUser = async (req, res) => {
  let {id, firstName, lastName, username, mobile, isAdmin } = req.body;
  try {
    await models.User.update( 
      {firstName, lastName, mobile, isAdmin: isAdmin ? true : false},
      {where: { id }}
    );
    res.send('User upadated!');
  } catch (error) {
    console.log(error);
        res.send('Can not edit user!');
  }

}
module.exports = controller;
