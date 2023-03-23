const initialState = {
}

export default function BookPageReducer(state = initialState, action) {
    switch (action.type) {
        case 'bookpage/axiosget': {
            return {
                ...state,
                books: action.payload
            }
        }
        case 'bookpage/getChapter': {
            console.log(action.payload)
            return {
                ...state,
                chapter: action.payload
            }
        }
        default:
            return state
    }
}