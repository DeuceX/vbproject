import CounterExample from './pages/counter/components/counter-example'
import FetchData from './pages/counter/components/fetch-data'
import HomePage from 'components/home-page'
import CardDetails from './pages/card-details/components/card-details'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/card-details/:id', component: CardDetails, props: true },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' }
];
