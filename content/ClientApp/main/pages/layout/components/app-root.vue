<template>
  <div id="app">
    <div class="wrapper">
      <my-header></my-header>
      <router-view></router-view>
    </div>
  </div>
</template>
<script>
  import Vue from 'vue'
  import HomePage from './home-page'
  import header from './header'
  import AccountPage from 'C:/www/cases/vbproject/content/ClientApp/main/pages/account/account.vue'

  Vue.component('home-page', HomePage);
  Vue.component('account', AccountPage);  
  Vue.component('my-header', header);

  export default {
    data() {
      return {}
    }
  }
</script>
<style>
</style>
