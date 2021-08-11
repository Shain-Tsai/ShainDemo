<template>
  <main ref="top-main">
    <router-view></router-view>
  </main>
</template>

<script>
export default {
    name: 'TopMain',
    watch: {
        $route(to) {
            this.setTopPadding(to.name)
        }
    },
    methods: {
        setTopPadding(pathName) {
            const topMain = this.$refs['top-main']
            pathName === 'Home' ? topMain.classList.add('index-page') : topMain.classList.remove('index-page')
        }
    }
}
</script>

<style lang="scss" scoped>
main {
  min-height: 100vh;
  padding-top: 5rem;

  &.index-page {
    padding-top: 0;
  }
}
</style>