/*
 * Copyright 2016 MovingBlocks
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package org.terasology.rendering.dag.tasks;

import static org.lwjgl.opengl.GL11.glEnable;
import org.terasology.rendering.dag.RenderPipelineTask;

/**
 * TODO: Add javadocs
 */
public final class EnableStateParameterTask implements RenderPipelineTask {
    private int parameter;
    private String parameterName;

    public EnableStateParameterTask(int parameter, String parameterName) {
        this.parameter = parameter;
        this.parameterName = parameterName;
    }

    @Override
    public void execute() {
        glEnable(parameter);
    }

    @Override
    public String toString() {
        return String.format("%30s: %s enabled", this.getClass().getSimpleName(), parameterName);
    }
}
