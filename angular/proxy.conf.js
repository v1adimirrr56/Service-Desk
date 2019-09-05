const PROXY_CONFIG = [
  {
    context: [
      "/api",
    ],
    target: "http://localhost:50562",
    secure: false
  }
];

module.exports = PROXY_CONFIG;
