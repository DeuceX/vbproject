<template>
  <div class="main flex-row">
    <div class="main__parallax">
      <div id="scene">
        <div class='stars stars--1' data-depth="0.4"></div>
        <div class='stars stars--2' data-depth="0.2"></div>
        <div class='stars stars--3' data-depth="0.6"></div>
      </div>
    </div>
    <div class="main__form">
      <div class="main__form-top">
        <div class="header__logo">try it yourself</div>
        <div class="main__separator">or</div>
        <div class="main__login" v-on:click="login">login</div>
      </div>
      <form class="form form-btn-right">
        <div class="form__item"><input type="text" placeholder="Name Surname"></div>
        <div class="form__item"><input type="text" placeholder="Nickname"></div>
        <div class="form__item"><input type="email" placeholder="Email"></div>
        <div class="form__item"><input type="password" placeholder="Password"></div>
        <button class="form__btn">Go</button>
      </form>
    </div>

    <!-- <div class="main__form">
      <div class="main__form-top">
        <div class="header__logo">Login</div>
        <div class="main__separator">or</div>
        <div class="main__login">try it now</div>
      </div>
      <form class="form form-btn-right">
        <div class="form__item"><input type="email" placeholder="Email"></div>
        <div class="form__item"><input type="password" placeholder="Password"></div>
        <button class="form__btn">Go</button>
      </form>
    </div> -->

  </div>
</template>
<script>
  export default {
    data() {
      return {}
    },
    methods: {
      login: function () {
        this.classList.toggle('active');
      }
    }
  }
  import Parallax from 'parallax-js/dist/parallax';
  window.onload = function() {
    var scene = document.getElementById('scene');
    var parallaxInstance = new Parallax(scene, {
      relativeInput: true
    });
  }
</script>
