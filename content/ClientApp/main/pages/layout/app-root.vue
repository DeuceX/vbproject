<template>
  <div id="app" :class="$route.path==='/' ? 'mainpage' : ''">
    <div class="wrapper">
      <my-header></my-header>
      <router-view></router-view>
    </div>
  </div>
</template>
<script>
  import Vue from 'vue'
  import HomePage from './components/home-page'
  import header from './components/header'
  import AccountPage from '../account/account'
  import SettingsPage from '../settings/settings'  

  Vue.component('home-page', HomePage);  
  Vue.component('account', AccountPage);  
  Vue.component('my-header', header);
  Vue.component('settings', SettingsPage);

  export default {
    data() {
      return {}
    },
  }
</script>
