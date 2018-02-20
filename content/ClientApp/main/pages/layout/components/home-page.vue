<template>
    <div class="home">
        <h1>Hello!</h1>
        <div class="container">
            <div class="row">
                <div class="col-md-4" v-for="card in cards">
                    <h3>{{ card.name }}</h3>
                    <h4>{{ card.description }}</h4>
                    <router-link :to="'/card-details/' + card.id">
                        <img :src="card.imageUrl" alt="card photo" />
                    </router-link>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        data() {
            return {
                cards: null
            }
        },
        async created() {
            try {
                let response = await this.$http.get('/api/Card/GetAll');
                this.cards = response.data;
                console.log(this.cards);
            } catch (error) {
                console.log(error)
            }
        }
    }
</script>
<style>
    .home img {
        width: 200px;
        cursor: pointer;
    }
</style>
