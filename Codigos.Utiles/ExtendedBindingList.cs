using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel;

namespace Codigos.Utiles
{
    /// <summary>
    /// Extención de la clase SortableBindingList que permite, además del ordenamiento y 
    /// la búsqueda de sus elementos, el filtrado de los mismos. Para esto utiliza un
    /// predicado basado en el tipo del objeto contenido en la lista.
    /// </summary>
    /// <typeparam name="T">Clase a instanciar.</typeparam>
    public class ExtendedBindingList<T> : SortableBindingList<T>
    {
        private List<T> invisibleItems = new List<T>();

        /// <summary>
        /// Crea una Instancia vacia basada en el tipo dado
        /// </summary>
        public ExtendedBindingList() : base(new List<T>())
        {
            
        }

        /// <summary>
        /// Crea una nueva instancia usando una lista del tipo pasado.
        /// </summary>
        /// <param name="values">Enumeración de la lista original.</param>
        public ExtendedBindingList(IEnumerable<T> values) : base(new List<T>(values))
        {
            
        }

        /// <summary>
        /// Aplica un filtro a la colección de objetos subyacentes de acuerdo al criterio pasado
        /// </summary>
        /// <param name="predicate">Delega con la funcionalidad que decide cuando un objeto de la 
        /// lista se debe filtrar o no.</param>
        public void SimpleFilter(Predicate<T> predicate)
        {
            // Restablece el filtro, agrega todos los elementos 'invisibleItmems' al bindingList
            foreach(T item in this.invisibleItems)
                base.Items.Add(item);

            this.invisibleItems.Clear();

            // aplica el filtro
            if(predicate != null)
            {
                // blucle de todos los elementos en la lista vinculante
                for (var index = Items.Count - 1; index > 0; --index)
                {
                    // Comprueba si es necesario incluirlo o no
                    if (!predicate(Items[index]))
                    {
                        // Lo agrega al 'invisibleItems'
                        this.invisibleItems.Add(Items[index]);

                        // Lo elimina de la lista vinculante
                        Items.RemoveAt(index);
                    }
                }
            }
            base.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

    }
}
