module.exports = {
  entry: "src/Extension.fsproj",
  outDir: "out",
  babel: {
    plugins: ["@babel/plugin-transform-modules-commonjs"]
  }
}