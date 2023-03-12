
// Kütüphaneler import ediliyor
// useSelector Redux kütüphanesinden geliyor
// useSelector Redux Store da depolanan verileri okumaya yarıyan bir hook fonksiyonu
// useSelector Reactdaki useState veya useEffect gibi çalışan bir fonksiyon
import React from 'react'
import { useSelector } from 'react-redux'
import TodoListItem from './TodoListItem'


// bu kısımlar reactdaki useState gibi
// selectTodos değişkeni tanımlanıyor
// TodoList methodunda useSelector çağrılarak Redux Stordan veriler geliyor.
const selectTodos = state => state.todos

// First time the TodoList component renders,
// useSelector hook will call selectTodos and
// pass entire Redux state object.
// So the const todos in our component
// will end up holding the same state.todos
// array inside our Redux store state

// Fortunately, useSelector automatically 
// subscribes to the Redux store for us! 
// That way, any time an action is dispatched,
// it will call its selector function again       
// right away.If the value returned by the selector 
// changes from the last time it ran, useSelector 
// will force our component to re - render with the 
// new data.All we have to do is call useSelector()
// once in our component, and it does the rest of the 
// work for us.
const TodoList = () => {

    const todos = useSelector(selectTodos)

    const renderedListItems = todos.map(todo => {
        return (
            <TodoListItem key={todo.id} todo={todo} />
        );
    })

    return (
        <ul className="todo-list">{renderedListItems}</ul>
    );
}
export default TodoList