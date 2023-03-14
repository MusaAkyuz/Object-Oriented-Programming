
const initialState = []

//function nextId(books) {
//    const maxId = books.reduce((maxId, book) => Math.max(book.id, maxId), -1)
//    return maxId + 1
//}

export default function BookPageReducer(state = initialState, action) {
    switch (action.type) {
        case 'bookpage/axiosget': {
            console.log(action.payload)
            return {
                ...state,
                books: action.payload
            }
        }
        default:
            return state
    }
}