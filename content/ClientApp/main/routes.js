import HomePage from 'components/home-page'
import AccountPage from './pages/account/account'
import SettingsPage from './pages/settings/settings'
import CardDetails from './pages/card-details/components/card-details'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },   
    { path: '/card-details/:id', component: CardDetails, props: true },
    { path: '/account', component: AccountPage, display: 'Account', style: 'glyphicon glyphicon-account'},
    { path: '/account/settings', component: SettingsPage, display: 'Settings', style: 'glyphicon glyphicon-settings'}
];
