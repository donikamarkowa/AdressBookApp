const PROXY_CONFIG = [
  {
    context: [
      "/аpi",
    ],
    target: "https://localhost:7145",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
