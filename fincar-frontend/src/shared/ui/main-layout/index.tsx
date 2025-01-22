import { Layout } from "antd";
import { Outlet } from "react-router-dom";
import styles from "./index.module.css"

export const MainLayout = () => {
    return (
        <Layout className={styles.headerWrapper}>
            <Layout.Content className={styles.headerContent}>
                <Outlet />
            </Layout.Content>
        </Layout>
    )
}