import HomePage from 'components/home-page'
import AccountPage from './pages/account/account'
import CardDetails from './pages/card-details/components/card-details'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/card-details/:id', component: CardDetails, props: true },
    { path: '/account', component: AccountPage, display: 'Account', style: 'glyphicon glyphicon-account'},
];
