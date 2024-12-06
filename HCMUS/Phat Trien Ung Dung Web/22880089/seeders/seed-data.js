"use strict";

const { faker } = require("@faker-js/faker");
const bcrypt = require("bcryptjs");
const start = "2023-01-01"; // Ngày bắt đầu
const end = "2024-11-30"; // Ngày kết thúc

function randomDate(startDate = start, endDate = end) {
  // Chuyển đổi ngày bắt đầu và kết thúc thành timestamp
  const startTimestamp = new Date(startDate).getTime();
  const endTimestamp = new Date(endDate).getTime();

  // Phát sinh timestamp ngẫu nhiên trong khoảng từ start đến end
  const randomTimestamp =
    Math.floor(Math.random() * (endTimestamp - startTimestamp + 1)) +
    startTimestamp;

  // Chuyển timestamp ngẫu nhiên thành đối tượng Date
  return new Date(randomTimestamp);
}

module.exports = {
  async up(queryInterface, Sequelize) {
    // Hash passwords
    const hashPassword = async (password) => await bcrypt.hash(password, 10);

    // Create Users
    const users = [];
    for (let i = 1; i <= 10; i++) {
      users.push({
        id: i,
        username: `user${i}`,
        email: `user${i}@example.com`,
        password: await hashPassword("password123"),
        bio: faker.lorem.sentence(),
        profilePicture: faker.image.avatar(),
        createdAt: randomDate(),
        updatedAt: randomDate(),
      });
    }

    // Insert Users
    await queryInterface.bulkInsert("Users", users);

    // Get User IDs
    const userIds = (
      await queryInterface.sequelize.query('SELECT id FROM "Users"')
    )[0];

    // Create Threads
    const threads = [];
    for (let i = 1; i <= 15; i++) {
      const randomUser = userIds[Math.floor(Math.random() * userIds.length)];
      threads.push({
        userId: randomUser.id,
        content: faker.lorem.paragraph(),
        mediaUrl: `/assets/images/${i}.jpg`,
        createdAt: randomDate(),
        updatedAt: randomDate(),
      });
    }

    // Insert Threads
    await queryInterface.bulkInsert("Threads", threads);

    // Get Thread IDs
    const threadIds = (
      await queryInterface.sequelize.query('SELECT id FROM "Threads"')
    )[0];

    // Create Likes
    const likes = [];
    for (let i = 1; i <= 50; i++) {
      const randomUser = userIds[Math.floor(Math.random() * userIds.length)];
      const randomThread =
        threadIds[Math.floor(Math.random() * threadIds.length)];
      likes.push({
        userId: randomUser.id,
        threadId: randomThread.id,
        createdAt: randomDate(),
        updatedAt: randomDate(),
      });
    }

    // Insert Likes
    await queryInterface.bulkInsert("Likes", likes);

    // Create Comments
    const comments = [];
    for (let i = 1; i <= 30; i++) {
      const randomUser = userIds[Math.floor(Math.random() * userIds.length)];
      const randomThread =
        threadIds[Math.floor(Math.random() * threadIds.length)];
      comments.push({
        userId: randomUser.id,
        threadId: randomThread.id,
        content: faker.lorem.sentence(),
        createdAt: randomDate(),
        updatedAt: randomDate(),
      });
    }

    // Insert Comments
    await queryInterface.bulkInsert("Comments", comments);
  },

  async down(queryInterface, Sequelize) {
    await queryInterface.bulkDelete("Comments", null, {});
    await queryInterface.bulkDelete("Likes", null, {});
    await queryInterface.bulkDelete("Threads", null, {});
    await queryInterface.bulkDelete("Users", null, {});
  },
};
