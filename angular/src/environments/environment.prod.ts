import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Auth0',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44396/',
    redirectUri: baseUrl,
    clientId: 'Auth0_App',
    responseType: 'code',
    scope: 'offline_access Auth0',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44396',
      rootNamespace: 'Promact.Auth0',
    },
  },
} as Environment;
