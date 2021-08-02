module.exports = {
  chainWebpack: config => {
    config
      .plugin('html')
      .tap(args => {
        args[0].title= 'Shain\'s demo website'
        return args
      })
  },
  css: {
    loaderOptions: {
      sass: {
        additionalData: `@import "~@/assets/styles/variable.scss";`
      }
    }
  }
}
