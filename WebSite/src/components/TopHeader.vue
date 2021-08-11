<template>
  <header ref="top-header">
    <span>
      <router-link to="/">Shain</router-link>
    </span>
    <nav>
      <span>
        <a href="#about">About</a>
      </span>
      <span>
        <a href="#skill">Skill</a>
      </span>
      <span>
        <router-link to="/resume">Resume</router-link>
      </span>
      <span>
        <router-link to="/portfolio">Portfolio</router-link>
      </span>
    </nav>
  </header>
</template>

<script>
export default {
  name: 'TopHeader',
  watch: {
    $route(to) {
      this.setHeaderStyleAndScroll(to.name)
    }
  },
  methods: {
    setHeaderStyleAndScroll(pathName) {
      if(pathName === 'Home') {
        this.$refs['top-header'].classList.remove('deep');
        window.addEventListener('scroll', this.handleScroll)
      }
      else {
        this.$refs['top-header'].classList.add('deep');
        window.removeEventListener('scroll', this.handleScroll)
      }
    },
    handleScroll () {
      window.pageYOffset >= document.documentElement.clientHeight ? this.$refs['top-header'].classList.add('deep') : this.$refs['top-header'].classList.remove('deep')
    }
  }
}
</script>

<style lang="scss" scoped>
header {
  position: fixed;
  z-index: 1;
  display: flex;
  justify-content: space-between;
  background-color: transparent;
  width: 100%;
  height: 5rem;
  transition: 1s;

  /* 網站標題 */
  > span {
    padding: 1rem 2rem;
    > a {
      font-size: 2.4rem;
      font-weight: bold;
      color: $white;
    }
  }

  > nav {
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 0 2rem;

    > span {
      padding: 1rem;

      > a {
        font-weight: bold;
        color: $white;

        &.router-link-exact-active {
          color: $orange-web;
        }
      }
    }
  }

  &.deep {
    background-color: $black;
    color: $white;
  }
}
</style>