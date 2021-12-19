declare global {
    interface RouterMeta {
        title: string;
    }
    interface Router {
        path: string;
        name: string;
        icon?: string;
        permission?: string;
        meta?: RouterMeta;
        component: any;
        children?: Array<Router>;
    }
    interface System {
        import(request: string): Promise<any>
    }
    var System: System
}
import login from '../views/login.vue'
import home from '../views/home/home.vue'
import main from '../views/main.vue'

export const locking = {
    path: '/locking',
    name: 'locking',
    component: () => import('../components/lockscreen/components/locking-page.vue')
};
export const loginRouter: Router = {
    path: '/',
    name: 'login',
    meta: {
        title: 'LogIn'
    },
    component: () => import('../views/login.vue')
};
export const otherRouters: Router = {
    path: '/main',
    name: 'main',
    permission: '',
    meta: { title: 'ManageMenu' },
    component: main,
    children: [
        { path: 'home', meta: { title: 'HomePage' }, name: 'home', component: () => import('../views/home/home.vue') }
    ]
}
export const appRouters: Array<Router> = [{
    path: '/setting',
    name: 'setting',
    permission: '',
    meta: { title: 'Manage' },
    icon: '&#xe68a;',
    component: main,
    children: [
        { path: 'user', permission: 'Pages.Users', meta: { title: 'Users' }, name: 'user', component: () => import('../views/setting/user/user.vue') },
        { path: 'role', permission: 'Pages.Roles', meta: { title: 'Roles' }, name: 'role', component: () => import('../views/setting/role/role.vue') },
        { path: 'tenant', permission: 'Pages.Tenants', meta: { title: 'Tenants' }, name: 'tenant', component: () => import('../views/setting/tenant/tenant.vue') }
    ]
},
{
    path: '/todo',
    name: 'todo',
    permission: '',
    meta: { title: 'ToDo' },
    icon: '&#xe6f2;',
    component: main,
    children: [
        { path: 'definition', permission: 'Pages.Users', meta: { title: 'Definition' }, name: 'definition', component: () => import('../views/todo/definition/definition.vue') },
        { path: 'input', permission: 'Pages.Roles', meta: { title: 'Input' }, name: 'input', component: () => import('../views/todo/input/input.vue') },
        { path: 'stats', permission: 'Pages.Tenants', meta: { title: 'Stats' }, name: 'stats', component: () => import('../views/todo/stats/stats.vue') }
    ]
},
]
export const routers = [
    loginRouter,
    locking,
    ...appRouters,
    otherRouters
];
