const path = require("path");
const MiniCssExtractPlugin = require('mini-css-extract-plugin');

module.exports = {
  plugins: [
    new MiniCssExtractPlugin({
      filename: "Carbon.Components.Razor.styles.css",
    }),
  ],
  entry: './src/Carbon.Components.Razor/wwwroot/Carbon.Components.Razor.styles.scss',
  output: {
    path: path.resolve(__dirname, './src/Carbon.Components.Razor/wwwroot/')
  },
  module: {
    rules: [
    {
      test: /\.(woff(2)?|eot|ttf|otf|svg|)$/,
      type: 'asset/resource',
      parser: {
        dataUrlCondition: {
          maxSize: 8 * 1024 // 8kb
        }
      },
      generator: { 
        filename: './fonts/[name][ext]'
      },
    },    
    {
      test: /\.scss$/i,
      use: [
        {
          loader: MiniCssExtractPlugin.loader,
        },
        "css-loader","postcss-loader", "sass-loader"
      ],
    }]
  },
  devtool: 'source-map'
};