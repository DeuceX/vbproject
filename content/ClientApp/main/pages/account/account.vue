<template>
  <div class="cards">
    <account-info></account-info>
    <div class="cards__items flex-row align">
      <div 
        class="cards__item" 
        v-for="(card, index) in cards" 
        :key="index" 
        :class="card.isCompleted ? 'cards__done' : ''">
        <h3>{{ card.name }}</h3>
        <h4>{{ card.description }}</h4>
        <router-link :to="'/card-details/' + card.id">
          <div class="cards__img">
            <img src="./../../assets/data/card.png" alt="card" width="280" height="200" />
          </div>
        </router-link>
      </div>
    </div>
  </div>
</template>

<script>
  import AccountInfo from './components/account-info';

  export default {
    data() {
      return {
        cards: null
      }
    },
    components: {
      accountInfo: AccountInfo
    },
    async created() {
      try {
          let response = await this.$http.get('/api/Card/GetAll');
          this.cards = response.data;
      } catch (error) {
          console.log(error)
      }
    }
  }
</script>
