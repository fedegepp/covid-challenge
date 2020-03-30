export const environment = {
  production: false,
  application: {
    name: 'CovidChallenge',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313',
    clientId: 'CovidChallenge_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'CovidChallenge',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44313'
    }
  },
  localization: {
    defaultResourceName: 'CovidChallenge'
  }
};
