<template>
  <div id="top-banner" class="container">
    <div class="layer">
      <h1>Hello! I'm Shain Tsai</h1>
    </div>
  </div>
  <div class="container">
    <div ref="about" id="about" class="slide-target"></div>
    <h2>關於我 About</h2>
    <h3>Name: 蔡烜廷 Shain Tsai</h3>
    <router-link to="/about">About</router-link>
  </div>
  <div class="container">
    <div id="skill" class="slide-target"></div>
    <h2>技能 Skill</h2>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'

export default {
  name: 'Home',
  components: {
    HelloWorld
  }
}
</script>

<style lang="scss" scoped>
.container {
  position: relative;
  width: 100%;
  min-height: 100vh;
  padding: 1rem;

  &:nth-of-type(odd) {
    background-color: $platinum;
  }

  .slide-target {
    position: absolute;
    top: -5rem;
    height: 5rem;
  }
}

#top-banner {
  background-image: url("~@/assets/images/top-banner.jpg");
  background-size: cover;

  > .layer {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: fade($black, 50%);

    > h1 {
      @include absolute-center();
      color: $white;
    }
  }
}

</style>