const app = Vue.createApp({
    data() {
        return {
            categorias: [],
            ordenAsc: true,
            columnaOrden: '',
            mostrarModal: false,
            mostrarModalNueva: false,
            categoriaSeleccionada: {},
            nuevaCategoria: { descripcionCategoria: '', estado: true }
        };
    },
    mounted() {
        this.obtenerCategorias();
    },
    methods: {
        async obtenerCategorias() {
            try {
                const response = await axios.get('/Administration/Categorias', {
                    headers: { 'X-Requested-With': 'XMLHttpRequest' }
                });
                this.categorias = response.data;
            } catch (error) {
                console.error('Error al obtener categorías:', error);
            }
        },
        ordenarPor(columna) {
            if (this.columnaOrden === columna) {
                this.ordenAsc = !this.ordenAsc;
            } else {
                this.columnaOrden = columna;
                this.ordenAsc = true;
            }
            this.categorias.sort((a, b) => {
                let valA = a[columna];
                let valB = b[columna];

                if (typeof valA === 'string') valA = valA.toLowerCase();
                if (typeof valB === 'string') valB = valB.toLowerCase();

                return this.ordenAsc ? (valA > valB ? 1 : -1) : (valA < valB ? 1 : -1);
            });
        },
        abrirModal(categoria) {
            this.categoriaSeleccionada = { ...categoria };
            this.mostrarModal = true;
        },
        cerrarModal() {
            this.mostrarModal = false;
        },
        abrirModalNueva() {
            this.nuevaCategoria = { descripcionCategoria: '', estado: true };
            this.mostrarModalNueva = true;
        },
        cerrarModalNueva() {
            this.mostrarModalNueva = false;
        },
        async guardarCambios() {
            try {
                const response = await axios.put('/Administration/ActualizarCategoria', this.categoriaSeleccionada);
                alert(response.data);
                this.cerrarModal();
                this.obtenerCategorias(); // Actualiza la lista
            } catch (error) {
                console.error('Error al actualizar la categoría:', error);
                alert('Error al actualizar la categoría');
            }
        },
        async guardarNuevaCategoria() {
            try {
                const response = await axios.post('/Administration/CrearCategoria', this.nuevaCategoria);
                alert(response.data);
                this.cerrarModalNueva();
                this.obtenerCategorias(); // Actualiza la lista
            } catch (error) {
                console.error('Error al crear la categoría:', error);
                alert('Error al crear la categoría');
            }
        }
    }
});
app.mount('#app');