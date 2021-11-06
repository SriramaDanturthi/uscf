import { MainMenuLink } from '../app/interfaces/main-menu-link';

export const mainMenu: MainMenuLink[] = [
    {
        title: 'Cabinet Doors & Drawer Fronts',
        url: '/'
    },
    {
        title: 'Moldings',
        url: '/shop',
        customFields: {
            ignoreIn: ['spaceship'],
        },
    },
    {
        title: 'Accessories',
        url: '/shop/shop-grid-4-sidebar',
    },
    {
        title: 'Speciality Products',
        url: '/blog',
    },
    {
        title: 'Forms',
        url: '/account',
    },
    {
        title: 'Contact Us',
        url: '/site/about-us',
    },
];
