<template>
  <div class="permiso">
    <Toast position="top-right" />

    <DataTable
      ref="dt"
      :value="records"
      :selection.sync="selectedItems"
      dataKey="Id"
      :paginator="true"
      :rows="10"
      :filters="filters"
      class="p-datatable-sm p-datatable-striped"
      paginatorTemplate="FirstPageLink PrevPageLink PageLinks NextPageLink LastPageLink CurrentPageReport RowsPerPageDropdown"
      :rowsPerPageOptions="[5, 10, 25]"
      currentPageReportTemplate="mostrando {first} - {last} de {totalRecords} registros"
    >
      <template #header>
        <div class="table-header">
          <h5 class="mb-3">Manejar permisos</h5>
          <span class="p-input-icon-left">
            <i class="pi pi-search" />
            <InputText v-model="filters['global']" placeholder="Buscar" />
          </span>
        </div>
      </template>

      <Column field="NombreEmpleado" header="Nombre"></Column>
      <Column field="ApellidosEmpleado" header="Apellidos"></Column>
      <Column header="Tipo de permiso">
        <template #body="slotProps">
          {{ slotProps.data.TipoPermiso.Descripcion }}
        </template></Column
      >
      <Column header="Fecha" headerStyle="width: 20%">
        <template #body="slotProps">
          {{ formatDate(slotProps.data.FechaPermiso) }}
        </template>
      </Column>
      <Column headerStyle="width: 115px">
        <template #header>
          <Button
            icon="pi pi-plus"
            class="ml-4 p-button-rounded p-button-primary"
            @click="openNew"
          />
        </template>
        <template #body="slotProps">
          <Button
            icon="pi pi-pencil"
            class="p-button-rounded p-button-success mr-2"
            @click="edit(slotProps.data)"
          />
          <Button
            icon="pi pi-trash"
            class="p-button-rounded p-button-warning"
            @click="confirmDeleteItem(slotProps.data)"
          />
        </template>
      </Column>
    </DataTable>

    <Dialog
      :visible.sync="dialog"
      :style="{ width: '80vw', 'margin-top': '60px' }"
      header="Agregar permiso"
      :modal="true"
      class="p-fluid"
    >
      <div class="row">
        <div class="p-field col-6 mb-3">
          <label for="name">Nombre</label>
          <InputText
            id="name"
            v-model.trim="model.NombreEmpleado"
            required="true"
            autofocus
            :class="{ 'p-invalid': submitted && !model.NombreEmpleado }"
          />
          <small class="p-invalid" v-if="submitted && !model.NombreEmpleado">
            Nombre es requerido.
          </small>
        </div>

        <div class="p-field col-6 mb-3">
          <label for="lastname">Apellidos</label>
          <InputText
            id="lastname"
            v-model.trim="model.ApellidosEmpleado"
            required="true"
            :class="{ 'p-invalid': submitted && !model.ApellidosEmpleado }"
          />
          <small class="p-invalid" v-if="submitted && !model.ApellidosEmpleado">
            Apellidos es requerido.
          </small>
        </div>
      </div>

      <div class="row">
        <div class="p-field col-6 mb-3">
          <label for="tipoPermiso">Tipo de permiso</label>
          <Dropdown
            v-model="model.TipoPermisoId"
            :options="types"
            optionLabel="Descripcion"
            optionValue="Id"
            appendTo="body"
            required="true"
          />
          <small class="p-invalid" v-if="submitted && !model.TipoPermisoId">
            Tipo de permiso es requerido.
          </small>
        </div>

        <div class="p-field col-6 mb-3">
          <label for="tipoPermiso">Fecha</label>
          <Calendar
            dateFormat="dd/mm/yy"
            :locale="es"
            v-model="model.FechaPermiso"
            yearRange="2000:2030"
            appendTo="body"
            required="true"
            :manualInput="false"
            :baseZIndex="99999"
          />
          <small class="p-invalid" v-if="submitted && !model.FechaPermiso">
            Fecha de permiso es requerida.
          </small>
        </div>
      </div>

      <template #footer>
        <Button
          label="Cancelar"
          icon="pi pi-times"
          class="p-button-text"
          @click="hideDialog"
        />
        <Button
          label="Guardar"
          icon="pi pi-check"
          class="p-button-text"
          @click="save"
        />
      </template>
    </Dialog>

    <Dialog
      :visible.sync="deleteDialog"
      :style="{ width: '450px' }"
      header="Confirme"
      :modal="true"
    >
      <div class="confirmation-content">
        <i class="pi pi-exclamation-triangle mr-3" style="font-size: 2rem" />
        <span v-if="model">
          ¿Esta seguro que desea eliminar este registro?
        </span>
      </div>
      <template #footer>
        <Button
          label="No"
          icon="pi pi-times"
          class="p-button-text"
          @click="deleteDialog = false"
        />
        <Button
          label="Sí"
          icon="pi pi-check"
          class="p-button-text"
          @click="deleteItem"
        />
      </template>
    </Dialog>
  </div>
</template>

<script>
import DataTable from "primevue/datatable";
import Dialog from "primevue/dialog";
import Button from "primevue/button";
import Column from "primevue/column";
import InputText from "primevue/inputtext";
import Dropdown from "primevue/dropdown";
import Calendar from "primevue/calendar";
import Toast from "primevue/toast";

import PermisoService from "../services/permiso";
import * as moment from "moment";

import { required, minValue } from "vuelidate/lib/validators";

export default {
  name: "Permiso",
  components: {
    Dialog,
    DataTable,
    Button,
    Column,
    InputText,
    Dropdown,
    Calendar,
    Toast,
  },
  data() {
    return {
      records: null,
      dialog: false,
      deleteDialog: false,
      model: {},
      selectedItems: null,
      filters: {},
      submitted: false,
      types: null,
      es: {
        firstDayOfWeek: 0,
        dayNames: [
          "Domingo",
          "Lunes",
          "Martes",
          "Miercoles",
          "Jueves",
          "Viernes",
          "Sabado",
        ],
        dayNamesShort: ["Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab"],
        dayNamesMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa"],
        monthNames: [
          "Enero",
          "Febrero",
          "Marzo",
          "Abril",
          "Mayo",
          "Junio",
          "Julio",
          "Agosto",
          "Septiembre",
          "Octubre",
          "Noviembre",
          "Diciembre",
        ],
        monthNamesShort: [
          "Ene",
          "Feb",
          "Mar",
          "Abr",
          "May",
          "Jun",
          "Jul",
          "Ago",
          "Sep",
          "Oct",
          "Nov",
          "Dic",
        ],
        today: "Hoy",
        clear: "limpiar",
        dateFormat: "dd/mm/yy",
        weekHeader: "Wk",
      },
    };
  },
  validations: {
    model: {
      NombreEmpleado: { required },
      ApellidosEmpleado: { required },
      TipoPermisoId: { required, min: minValue(1) },
      FechaPermiso: { required },
    },
  },
  created() {
    this.permisoService = new PermisoService();
  },
  async mounted() {
    try {
      const { data } = await this.permisoService.get();
      this.records = data.Data;
      this.types = data.Tipos;
    } catch (error) {
      this.showErrorToastr(error);
    }
  },
  methods: {
    formatDate(date) {
      return moment(date).format("DD/MM/YYYY");
    },
    openNew() {
      this.model = {};
      this.submitted = false;
      this.dialog = true;
    },
    hideDialog() {
      this.dialog = false;
      this.submitted = false;
    },
    edit(item) {
      this.model = { ...item };
      this.model.FechaPermiso = new Date(this.model.FechaPermiso);
      this.dialog = true;
    },
    confirmDeleteItem(model) {
      this.model = model;
      this.deleteDialog = true;
    },
    showErrorToastr(error) {
      let message;

      try {
        message = error.response.data.detail;
      } catch (error) {
        message = "Error desconocido";
      }
      
      this.$toast.add({
        severity: "error",
        summary: "",
        detail: message,
        life: 3000,
      });
    },
    findIndexById(id) {
      let index = -1;
      for (let i = 0; i < this.records.length; i++) {
        if (this.records[i].Id === id) {
          index = i;
          break;
        }
      }

      return index;
    },
    async save() {
      this.$v.model.$touch();
      this.submitted = true;

      if (this.$v.model.$pending || this.$v.model.$error) return;

      try {
        if (this.model.Id) {
          const { data } = await this.permisoService.update(this.model);
          this.$set(this.records, this.findIndexById(data.Id), data);
        } else {
          const { data } = await this.permisoService.add(this.model);
          this.records.push(data);
        }

        this.dialog = false;
        this.model = {};
      } catch (error) {
        this.showErrorToastr(error);
      }
    },
    async deleteItem() {
      try {
        await this.permisoService.delete(this.model.Id);
        this.records = this.records.filter((val) => val.Id !== this.model.Id);
        this.deleteDialog = false;
        this.model = {};
      } catch (error) {
        this.showErrorToastr(error);
      }
    },
  },
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.permiso {
  margin-top: 80px;
}
</style>
