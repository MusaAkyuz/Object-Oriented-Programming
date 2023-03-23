import BookPage from './features/BookPage/BookPage'


const AppRoutes = [
  {
    index: true,
    element: <BookPage />
  },
  {
    path: '/books',
    element: <BookPage />
  }
];

export default AppRoutes;
