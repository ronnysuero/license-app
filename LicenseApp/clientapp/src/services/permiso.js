import axios from "axios";

export default class PermisoService {
  url = "http://localhost:50598/api/permiso/";

  async get() {
    return await axios.get(`${this.url}get`);
  }

  async add(model) {
    return await axios.post(`${this.url}add`, model);
  }

  async update(model) {
    return await axios.put(`${this.url}update`, model);
  }

  async delete(id) {
    return await axios.delete(`${this.url}delete/${id}`);
  }
}
