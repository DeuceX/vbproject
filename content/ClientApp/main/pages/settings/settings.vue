<template>
  <div class="settings align flex-row">
    <div class="settings__nav">
      <router-link 
        :to="'/account/settings/edit'"
        class="settings__link active">
        <span>Edit profile</span>
      </router-link>
      <router-link 
        :to="'/account/settings/password'" 
        class="settings__link">
        <span>Change password</span>
      </router-link>
      <router-link 
        :to="'#'" 
        class="settings__link">
        <span>Logout</span>
      </router-link>  
    </div>
    <div class="settings__content">
      <!-- <edit-profile></edit-profile> -->
      <change-pass></change-pass>
    </div>
  </div>
</template>

<script>
  import EditProfile from './components/edit-profile';
  import ChangePass from './components/change-pass';

  export default {
    data() {
      return {}
    },
    components: {
      editProfile: EditProfile,
      changePass: ChangePass
    }
  }
</script>
