import rootReducer from './reducer'
import { createStore, applyMiddleware } from 'redux'
import { composeWithDevTools } from 'redux-devtools-extension'

const composedEnhancer = composeWithDevTools(
    // Add whatever middleware you actually want to use here
    applyMiddleware()
    // other store enhancers if any
)

const store = createStore(rootReducer, composedEnhancer)
export default store