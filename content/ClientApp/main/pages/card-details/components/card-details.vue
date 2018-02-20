<template>
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Card details</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <h3>{{ card.name }}</h3>
                <h4>{{ card.description }}</h4>
                <img :src="card.imageUrl" alt="card photo" />
            </div>
        </div>
    </div>
</template>
<script>
    export default {
        data() {
            return {
                forecasts: null,
                card: {}
            }
        },

        methods: {
        },

        props: ['id'],

        async created() {
            try {
                let response = await this.$http.get('/api/Card/Get/' + this.id);
                this.card = response.data;
                console.log(this.card);
            } catch (error) {
                console.log(error)
            }
        }
    }
</script>
<style>
</style>
