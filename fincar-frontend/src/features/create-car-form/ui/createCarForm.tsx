import { ImageUploader } from 'shared/ui/image-uploader'
import styles from './createCarForm.module.css'
import { UploadFile } from 'antd'
import { observer } from 'mobx-react-lite'
import { useState } from 'react'

export const CreateCarForm = observer(() => {
    const [fileList, setFileList] = useState<UploadFile[]>([]);

  return(
        <div className={styles.wrapper}>
            <h2>Images of car</h2>
            <div className={styles.imageBox}>
                <ImageUploader fileList={fileList} setFileList={setFileList} />
            </div>

        </div>
    )
})