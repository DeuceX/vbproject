<template>
  <div class="main flex-row">
    <div id="scene" class="main__parallax">
      <div class="main__parallax--1"><img src="/ClientApp/main/assets/data/1.png"></div>
      <div class="main__parallax--2"><img src="/ClientApp/main/assets/data/2.png"></div>
      <div class="main__parallax--3"><img src="/ClientApp/main/assets/data/3.png"></div>
    </div>
    <div class="main__form flex-col">
      <div class="header__logo">try it yourself</div>
    </div>
  </div>
</template>
<script>
  export default {
    data() {
      return {}
    }
  }
  import Parallax from 'parallax-js/dist/parallax.min';
  var scene = document.getElementById('scene');
  var parallaxInstance = new Parallax(scene);
</script>
