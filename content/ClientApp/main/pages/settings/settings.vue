<template>
  <div class="settings align flex-row">
    <div class="settings__nav">
      <div 
        class="settings__link" 
        v-for="(tab, tabIndex) in tabs"
        v-on:click="activeTab(tabIndex)"
        :class="{ active: (tabIndex == index) ? true : false }"> 
        {{ tab.name }} {{ tabIndex }}
      </div>
      <!-- <router-link 
        :to="'/account/settings/edit'"
        class="settings__link active">
        <span>Edit profile</span>
      </router-link>
      <router-link 
        :to="'/account/settings/password'" 
        class="settings__link">
        <span>Change password</span>
      </router-link> -->
      <router-link 
        :to="'#'" 
        class="settings__link">
        <span>Logout</span>
      </router-link>
    </div>
    <div 
      class="settings__content"
      v-for="tab in tabs">
      {{ tab.content }}
      <!-- <edit-profile></edit-profile> -->
      <!-- <change-pass></change-pass> -->
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
            content: '123'
          },
          {
            tabIndex: 1,
            name: 'Change password',
            content: '321'
          }
        ]
      }
    },
    components: {
      editProfile: EditProfile,
      changePass: ChangePass
    },
    methods: {
      activeTab: function(tab) {
        this.index == tabIndex
      }
    }
  }
</script>
