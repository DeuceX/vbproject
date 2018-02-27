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
        <a href="#" class="main__login">login</a>
      </div>
      <form class="form form-btn-right">
        <div class="form__item"><input v-model="name" type="text" placeholder="Name Surname"></div>
        <div class="form__item"><input v-model="nick" type="text" placeholder="Nickname"></div>
        <div class="form__item"><input v-model="email" type="email" placeholder="Email"></div>
        <div class="form__item"><input v-model="pass" type="password" placeholder="Password"></div>
        <button @click.prevent="register" class="form__btn">Go</button>
        <button @click.prevent="login" class="form__btn">Login</button>
      </form>
    </div>
  </div>
</template>
<script>
    import * as authService from './../../authorization/api/authorization-service'

  export default {
    data() {
        return {
            name: '',
            email: '',
            nick: '',
            pass: ''
        }
        },
    methods: {
        register: function () {
            let usr = {
                Email: this.email,
                UserName: this.name,
                FullName: this.name,
                Password: this.pass
            }
            authService.registr(usr);
        },
        login: function () {
            let data = {
                Email: this.email,
                Password: this.pass,
                RememberMe: true
            }
            let response = authService.login(data)
                .then(function (response) {
                    localStorage.setItem("token", response.data.token);
                });
        }
    }
  }
  import Parallax from 'parallax-js/dist/parallax';
  window.onload = function() {
      var scene = document.getElementById('scene');
      if (scene) {
          var parallaxInstance = new Parallax(scene, {
              relativeInput: true
          });
      }
  }
</script>
