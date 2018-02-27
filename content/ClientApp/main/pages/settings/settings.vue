<template>
  <div class="settings align flex-row">
    <div class="settings__nav">
      <div 
        class="settings__link" 
        v-for="(tab, tabIndex) in tabs"
        v-on:click="index = tabIndex"
        :key="tabIndex"
        :class="(tabIndex == index) ? 'active' : ''"> 
        {{ tab.name }}
      </div>
      <router-link 
        :to="'#'" 
        class="settings__link">
        <span>Logout</span>
      </router-link>
    </div>
    <div 
      class="settings__content"
      v-for="(tab, tabIndex) in tabs"
      :class="(tabIndex == index) ? 'active' : ''"
      :key="tabIndex + 10">
      <component :is="tabs[tabIndex].content"></component>
    </div>
  </div>
</template>

<script>
  import EditProfile from './components/edit-profile';
  import ChangePass from './components/change-pass';

  export default {
    data() {
      return {
        index: 0,
        tabs: [
          {
            tabIndex: 0,
            name: 'Edit profile',
            content: 'edit-profile'
          },
          {
            tabIndex: 1,
            name: 'Change password',
            content: 'change-pass'
          }
        ]
      }
    },
    components: {
      editProfile: EditProfile,
      changePass: ChangePass
    }
  }
</script>
