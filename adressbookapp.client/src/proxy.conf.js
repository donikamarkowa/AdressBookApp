const PROXY_CONFIG = [
  {
    context: [
      "/аpi",
    ],
    target: "https://localhost:7145/api",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
