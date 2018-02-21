<template>
    <div id="app">
        <div class="wrapper">
          <router-view></router-view>
        </div>
    </div>
</template>
<script>
    import Vue from 'vue'
    import CounterExample from './../../counter/components/counter-example'
    import HomePage from './home-page'

    Vue.component('counter-example', CounterExample);
    Vue.component('home-page', HomePage);

    export default {
        data() {
            return {
            }
        }
    }
</script>
<style>
</style>
