<template>
  <form class="form settings__form flex-row">
    <div class="settings__change form-btn-right">
      <label class="form__item">
        <span>Name Surname:</span>
        <input type="text">
      </label>
      <label class="form__item">
        <span>Nickname:</span>
        <input type="text">
      </label>
      <label class="form__item">
        <span>About:</span>
        <textarea></textarea>
      </label>
      <button class="form__btn">Ok</button>
    </div>
    <div class="settings__avatar flex-col">
      <div class="settings__img">
        <!-- <img src="" alt="" width="100" height="100"> -->
      </div>
      <label class="form__file">
        <input type="file">
        <span class="">Change Photo</span>
      </label>
    </div>
  </form>
</template>
<script>
  export default {
    data() {
      return {}
    }
  }
</script>
