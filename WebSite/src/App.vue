<template>
  <header ref="top-header" id="top-header">
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
  
  <main id="top-main">
    <router-view />
  </main>
  
</template>

<script>

export default {
  watch: {
    $route(to) {
      to.name === 'Home' ? window.addEventListener('scroll', this.handleScroll) : window.removeEventListener('scroll', this.handleScroll)
    }
  },
  methods: {
    handleScroll () {
      const topHeader = this.$refs['top-header']
      window.pageYOffset >= document.documentElement.clientHeight ? topHeader.classList.add('deep') : topHeader.classList.remove('deep')
    }
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

#top-header {
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

#top-main {
  min-height: 100vh;
}
</style>
