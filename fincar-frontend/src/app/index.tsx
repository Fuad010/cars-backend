import { RouterProvider } from "react-router-dom"
import { router } from "./routers/appRouter"
import 'shared/config/styles/reset.css'
import 'shared/config/styles/index.css'

export const App = () =>{
    return <RouterProvider router={router}/>
}