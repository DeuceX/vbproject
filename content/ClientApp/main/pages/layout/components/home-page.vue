<template>
  <div class="main flex-row">
    <div id="scene" class="main__parallax">
      <div class="main__parallax--1"><img src="/ClientApp/main/assets/data/1.png"></div>
      <div class="main__parallax--2"><img src="/ClientApp/main/assets/data/2.png"></div>
      <div class="main__parallax--3"><img src="/ClientApp/main/assets/data/3.png"></div>
    </div>
    <div class="main__form flex-col">
      <div class="main__form-top">
        <div class="header__logo">try it yourself</div>
        <div class="main__separator">or</div>
        <a href="#" class="main__login">login</a>
      </div>
      <form class="form form-btn-right">
        <div class="form__item"><input type="text" placeholder="Name Surname"></div>
        <div class="form__item"><input type="text" placeholder="Nickname"></div>
        <div class="form__item"><input type="email" placeholder="Email"></div>
        <div class="form__item"><input type="password" placeholder="Password"></div>
        <button class="form__btn">Go</button>
      </form>
    </div>
  </div>
</template>
<script>
  export default {
    data() {
      return {}
    }
  }
  // import Parallax from 'parallax-js/dist/parallax.min';
  // var scene = document.getElementById('scene');
  // var parallaxInstance = new Parallax(scene);
</script>
