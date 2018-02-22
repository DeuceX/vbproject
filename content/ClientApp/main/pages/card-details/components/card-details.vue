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
                <div class="img-wrap">
                    <img :src="card.imageUrl" alt="card photo" />
                    <div v-if="card.isCompleted" class="completed">
                        This Card is Completed!
                    </div>
                </div>
            </div>
        </div>
        <div class="row" v-if="card.isCompleted">
            <div class="col-md-12">
                <h3>This card was completed!</h3>
                <hr />
                <h4><i>Your comment:</i></h4>
                <h4>{{ card.comment }}</h4>
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
            } catch (error) {
                console.log(error)
            }
        }
    }
</script>
