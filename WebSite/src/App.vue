<template>
  <top-header></top-header>
  <top-main></top-main>
</template>

<script>
import TopHeader from './components/TopHeader.vue'
import TopMain from './components/TopMain.vue'

export default {
  components: {
    TopHeader,
    TopMain
  }
}
</script>

<style lang="scss">
body {
  font-family: Microsoft YaHei, Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  margin: 0rem;
  font-size: 1.6rem;
}
</style>
