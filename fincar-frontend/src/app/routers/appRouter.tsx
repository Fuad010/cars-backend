import { CarListPage } from "pages/car-list-page";
import { createBrowserRouter } from "react-router-dom";
import { Layout } from "app/layout";

export const router = createBrowserRouter([
    {
        path: '/',
        element: <Layout/>,
        children: [
            {
                index: true,
                element: <>car</>
            },
            {
                path: ":id",
                element: <>car detail</>
            }
        ]
    }
])