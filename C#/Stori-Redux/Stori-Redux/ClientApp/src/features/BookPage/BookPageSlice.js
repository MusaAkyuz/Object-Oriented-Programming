
const initialState = {
}

//function nextId(books) {
//    const maxId = books.reduce((maxId, book) => Math.max(book.id, maxId), -1)
//    return maxId + 1
//}

export default function BookPageReducer(state = initialState, action) {
    switch (action.type) {
        case 'bookpage/axiosget': {
            return {
                ...state,
                books: action.payload
            }
        }
        case 'bookpage/selectbook': {
            console.log(action.payload)
            return {
                ...state,
                selectedBookName: action.payload[0],
                selectedBookAuthor: action.payload[1],
                selectedBookChapter: action.payload[2],
            }
        }
        default:
            return state
    }
}