<template>
  <div id="app">
    <Layout>
      <Permiso />
    </Layout>
  </div>
</template>

<script>
import Layout from "./components/Layout.vue";
import Permiso from "./components/Permiso.vue";

export default {
  name: "app",
  components: {
    Layout,
    Permiso,
  },
};
</script>
