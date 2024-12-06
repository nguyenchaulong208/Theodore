const DataTypes = require("sequelize").DataTypes;
const _Comment = require("./Comment");
const _Like = require("./Like");
const _Thread = require("./Thread");
const _User = require("./User");

function initModels(sequelize) {
  const User = _User(sequelize, DataTypes);
  const Thread = _Thread(sequelize, DataTypes);
  const Comment = _Comment(sequelize, DataTypes);
  const Like = _Like(sequelize, DataTypes);

  Comment.belongsTo(Thread, { foreignKey: "threadId" });
  Thread.hasMany(Comment, { foreignKey: "threadId" });
  Like.belongsTo(Thread, { foreignKey: "threadId" });
  Thread.hasMany(Like, { foreignKey: "threadId" });
  Comment.belongsTo(User, { foreignKey: "userId" });
  User.hasMany(Comment, { foreignKey: "userId" });
  Like.belongsTo(User, { foreignKey: "userId" });
  User.hasMany(Like, { foreignKey: "userId" });
  Thread.belongsTo(User, { foreignKey: "userId" });
  User.hasMany(Thread, { foreignKey: "userId" });

  return {
    Comment,
    Like,
    Thread,
    User,
  };
}
module.exports = initModels;
module.exports.initModels = initModels;
module.exports.default = initModels;
