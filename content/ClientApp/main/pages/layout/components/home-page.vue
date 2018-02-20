<template>
    <div class="home">
        <h1>Hello!</h1>
        <div class="container">
            <div class="row">
                <div class="col-md-4" v-for="card in cards">
                    <h3>{{ card.name }}</h3>
                    <h4>{{ card.description }}</h4>
                    <router-link :to="'/card-details/' + card.id">
                        <div class="img-wrap">
                            <img :src="card.imageUrl" alt="card photo" />
                            <div v-if="card.isCompleted" class="completed">
                                This Card is Completed!
                            </div>
                        </div>
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
        min-height: 300px;
    }

    .img-wrap {
        position: relative;
        display: inline-block;
    }

        .img-wrap .completed {
            position: absolute;
            width: 100%;
            height: 50%;
            background: rgba(48, 82, 5, 0.80);
            left: 0;
            top: 50%;
            border-radius: 15px;
            text-align: center;
            padding-top: 25%;
            font-size: 24px;
            font-weight: 600;
            font-style: italic;
            color: aquamarine;
        }
</style>
