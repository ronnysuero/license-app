import Vue from "vue";
import App from "./App.vue";
import Vuelidate from "vuelidate";
import ToastService from "primevue/toastservice";

import "bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import "primevue/resources/themes/saga-blue/theme.css";
import "primevue/resources/primevue.min.css";
import "primeicons/primeicons.css";

Vue.use(Vuelidate);
Vue.use(ToastService);

Vue.prototype.$primevue = { ripple: true };
Vue.config.devtools = true;
Vue.config.productionTip = false;

new Vue({
  render: (h) => h(App),
}).$mount("#app");
